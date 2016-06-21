using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * 2016.6.18 
 * By wyc
 * Wave Painting
 * 所有的图形操作都基于teechart的工具，没有使用到任何gdi+绘图操作,请仔细查看teechart和所添加的控件
 */
namespace Wave
{
    public partial class Form2 : Form
    {
        //全局变量区
        string filepath;//打开的文件路径
        double[] Ydata;
        double[] Xdata;//第一个波形XY
        double[] zoomYdata;
        double[] zoomXdata;//第二个波形XY
        int dataLength = 0;//第一个波形数组长度
        int zoomdataLength = 0;//第二个波形数组长度
        const double timeInterval = 0.01;//采样间隔
        double beginX = 0.0, endX = 0.0;//鼠标选中的起始和结束坐标点
        double mouseMoveX = 0.0;//鼠标移动坐标点
        double cutbegin = 0.0, cutend = 0.0;//切除选中时的起始和结束坐标点
        List<string> applyName = new List<string>();//文件批操作记录的文件路径
        List<double[]> operatorSort = new List<double[]>();//记录一系列操作的顺序，只要是起始和结束的坐标点。如果是切割则double的两个点是起始和结束坐标，如果是前置零，则double第一个是置零的位置坐标，后一个是-1.0.
        Boolean cutFlag = false;//切除标志位
        Boolean chooseFlag = false;//选中标志位

        public Form2()
        {
            InitializeComponent();
        }
        //空间初始化
        void TeeChartInit()
        {
            tChart1.Axes.Bottom.Grid.Visible = true;
            tChart1.Axes.Top.Grid.Visible = true;
            tChart1.Axes.Left.Grid.Visible = true;
            tChart1.Axes.Right.Grid.Visible = true;
            tChart1.Axes.Top.Visible = true;
            tChart1.Axes.Left.Visible = true;
            tChart1.Axes.Right.Visible = true;
            tChart1.Axes.Top.Ticks.Visible = true;
            tChart2.Axes.Bottom.Grid.Visible = true;
            tChart2.Axes.Top.Grid.Visible = true;
            tChart2.Axes.Left.Grid.Visible = true;
            tChart2.Axes.Right.Grid.Visible = true;
            tChart2.Axes.Left.Visible = true;
            tChart2.Axes.Right.Visible = true;
            tChart2.Axes.Top.Visible = true;
            tChart2.Axes.Top.Ticks.Visible = true;
            tChart2.Axes.Left.Visible = true;
            tChart2.Axes.Right.Visible = true;
        }
        //窗体加载form1的文件目录，通过全局变量Form1.directory
        private void Form2_Load(object sender, EventArgs e)
        {
            TeeChartInit();
            string[] filename;
            try
            {
                for (int i = 0; i < Form1.node.Count; i++)
                {
                    filename = Directory.GetFiles(Form1.directory[i]);
                    Form1.node.Add(treeView1.Nodes.Add(Form1.directory[i]));
                    for (int j = 0; j < filename.Length; j++)
                    {
                        Form1.node[Form1.node.Count - 1].Nodes.Add(filename[j]);
                    }
                }
            }
            catch { }
        }
        //打开文件操作
        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //文件信息打印
            filepath=treeView1.SelectedNode.Text;
            if (filepath.LastIndexOf(".txt") != -1 || filepath.LastIndexOf(".TXT") != -1)//识别txt或TXT文件
            {
                richTextBox1.Text = "采样名称:" + filepath.Substring(filepath.LastIndexOf("\\") + 1) + "\n" +
                    "采样编号：" + "1" + "\n" +
                    "采样描述：" + "\n" +
                    "采样时间：" + "\n" +
                    "测点号：" + "01" + "\n" +
                    "灵敏度：" + "0.100" + "\n" +
                    "通道号：" + "1" + "\n" +
                    "内部放大" + "1.000000" + "\n" +
                    "外部放大" + "1.000000" + "\n" +
                    "文件类型" + "原始文件";
                //读取文件
                FileStream fs = new FileStream(filepath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                List<string> tmp = new List<string>();
                string aa;
                dataLength = 0;
                while ((aa = sr.ReadLine()) != null)
                {
                    tmp.Add(aa);
                    dataLength++;
                }
                sr.Close();
                fs.Close();
                tChart1.Series[0].Clear();
                tChart2.Series[0].Clear();
                //绘图
                Ydata = new double[dataLength];
                Xdata = new double[dataLength];
                for (int i = 0; i < dataLength; i++)
                {
                    Ydata[i] = Convert.ToDouble(tmp[i]);
                    Xdata[i] = timeInterval * i;
                }
                zoomdataLength = (int)(10.0 / timeInterval);//第二波形默认加载10s
                zoomXdata = new double[zoomdataLength];
                zoomYdata = new double[zoomdataLength];
                for (int i = 0; i < zoomdataLength; i++)
                {
                    zoomYdata[i] = Ydata[i];
                    zoomXdata[i] = timeInterval * i;
                }
                if (applyName.Contains(filepath))//元素被应用
                {
                    for (int i = 0; i < operatorSort.Count; i++)
                    {
                        double[] tmpSort = operatorSort[i];
                        if (tmpSort[1] == -1.0)//置零操作
                        {
                            setZeroFunc(tmpSort[0]);
                        }
                        else//剪切操作 
                        {
                            cutFunc(tmpSort[0], tmpSort[1]);
                        }
                    }
                }
                else//没有文件应用
                {
                }
                tChart1.Series[0].Add(Xdata, Ydata);
                if (zoomXdata != null && zoomYdata != null)
                {
                    tChart2.Series[0].Add(zoomXdata, zoomYdata);
                }
            }
            else
            {
                MessageBox.Show("未选中txt文件！");
            }
        }
        //此为测试按钮，可以把button1.visible设置为false。可以忽略
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<string> tmp = new List<string>();
            string aa;
            dataLength = 0;
            while ((aa = sr.ReadLine()) != null)
            {
                tmp.Add(aa);
                dataLength++;
            }
            sr.Close();
            fs.Close();
            Ydata = new double[dataLength];
            Xdata = new double[dataLength];
            for (int i = 0; i < dataLength; i++)
            {
                Ydata[i] = Convert.ToDouble(tmp[i]);
                Xdata[i] = timeInterval * i;
            } 
            tChart1.Series[0].Add(Xdata, Ydata);
        }
        //鼠标按下事件。用于放大波形，切割波形的起始坐标记录
        private void tChart1_MouseDown(object sender, MouseEventArgs e)
        {
            chooseFlag = true;
            colorBand1.Start = tChart1.Series[0].XScreenToValue(e.X);
            colorBand1.End = tChart1.Series[0].XScreenToValue(e.X);
            if (!cutFlag)//放大波形
            {
                if (e.Button == MouseButtons.Left)
                {
                    beginX = tChart1.Series[0].XScreenToValue(e.X);
                }
            }
            else//切除操作
            {
                if (e.Button == MouseButtons.Left)
                {
                    cutbegin = tChart1.Series[0].XScreenToValue(e.X);
                }
            }
        }
        //松开鼠标，执行切割和放大操作
        private void tChart1_MouseUp(object sender, MouseEventArgs e)
        {
            chooseFlag = false;
            if (!cutFlag)//选中查看操作
            {
                if (e.Button == MouseButtons.Left)
                {
                    endX = tChart1.Series[0].XScreenToValue(e.X);
                    if (beginX >= endX)//有人调皮从右向左选
                    {
                        double tmp = endX;
                        endX = beginX;
                        beginX = tmp;
                    }
                    if ((int)(beginX/timeInterval) <= 0)//如果选择到最左边，防止超过数组最左侧
                    {
                        beginX = 0.0;
                    }
                    if ((int)endX / timeInterval >= dataLength)//防止到数组最右侧
                    {
                        endX = dataLength * timeInterval - 1;
                    }
                    zoomdataLength = (int)((endX - beginX) / timeInterval);
                    zoomXdata = new double[zoomdataLength];
                    zoomYdata = new double[zoomdataLength];
                    int intbeginX = (int)(beginX / timeInterval);
                    for (int i = intbeginX; i < intbeginX + zoomdataLength; i++)
                    {
                        zoomYdata[i - intbeginX] = Ydata[i];
                        zoomXdata[i - intbeginX] = Xdata[i];
                    }
                    tChart2.Series[0].Add(zoomXdata, zoomYdata);
                }
            }
            else//切除操作
            {
                if (e.Button == MouseButtons.Left)
                {
                    cutend = tChart1.Series[0].XScreenToValue(e.X);
                    if (cutbegin >= cutend)//有人调皮从右向左选
                    {
                        double tmp = cutend;
                        cutend = cutbegin;
                        cutbegin = tmp;
                    }
                    if ((int)(cutbegin / timeInterval) <= 0)//如果选择到最左边
                    {
                        cutbegin = 0.0;
                    }
                    if ((int)cutend / timeInterval >= dataLength)//如果选择到最右边
                    {
                        cutend = dataLength * timeInterval - 1;
                    }
                    DialogResult dr = MessageBox.Show("是否确定切除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if ( dr== DialogResult.Yes)//如果确定切除，则执行切除操作
                    {
                        operatorSort.Add(new double[2] { cutbegin, cutend });
                        tChart1.Series[0].Clear();
                        tChart2.Series[0].Clear();
                        //剪切后的新数组
                        cutFunc(cutbegin, cutend);
                        tChart1.Series[0].Add(Xdata, Ydata);
                        tChart2.Series[0].Add(zoomXdata, zoomYdata);
                    }
                    cutFlag = false;
                }
            }
        }
        //置零函数。目的：根据输入的X坐标，产生新的第一个波形的数组和第二个波形的数组
        private void setZeroFunc(double X)
        {
            //更新第一个波形数据
            for (int i = 0; i < (int)(X / timeInterval); i++)
            {
                Ydata[i] = 0.0;
            }
            //更新第二个波形数据
            int intbeginX = (int)(beginX / timeInterval);
            for (int i = intbeginX; i < intbeginX + zoomdataLength; i++)
            {
                zoomYdata[i - intbeginX] = Ydata[i];
                zoomXdata[i - intbeginX] = Xdata[i];
            }
        }
        //切除函数。目的：根据输入的起始和结束坐标，产生新的第一个波形的数组和第二个波形的数组
        private void cutFunc(double begin,double end)
        {
            int newdataLength = dataLength - ((int)(end / timeInterval) - (int)(begin / timeInterval) + 1);//新的长度
            double[] newYdata = new double[newdataLength];
            double[] newXdata = new double[newdataLength];
            int j = 0;
            for (int i = 0; i < dataLength; i++)
            {
                if (i== (int)(begin / timeInterval))
                {
                    if ((int)(end / timeInterval) == dataLength - 1)
                    {
                        break;
                    }
                    else
                    {
                        i = (int)(end / timeInterval) + 1;
                    }
                }
                newYdata[j++] = Ydata[i];
            }
            for (int i = 0; i < newdataLength; i++)
            {
                newXdata[i] = i * timeInterval;
            }
            //产生新的Xdata和Ydata和新的长度
            Xdata = new double[newdataLength];
            Ydata = new double[newdataLength];
            newXdata.CopyTo(Xdata, 0);
            newYdata.CopyTo(Ydata, 0);
            dataLength = newdataLength;
            //更新第二个波形
            if (beginX <= begin)//放大起始点在切除点之前
            {
                if ((int)(beginX / timeInterval) + zoomdataLength <= dataLength)//第二个波形放大长度没超过结尾
                {
                    int k = 0;
                    zoomXdata = new double[zoomdataLength];
                    zoomYdata = new double[zoomdataLength];
                    for (int i = (int)(beginX / timeInterval); i < (int)(beginX / timeInterval) + zoomdataLength; i++)
                    {
                        zoomYdata[k] = Ydata[i];
                        zoomXdata[k] = Xdata[i];
                        k++;
                    }
                }
                else//超过结尾
                {
                    int k = 0;
                    zoomXdata = new double[dataLength - (int)(beginX / timeInterval)];
                    zoomYdata = new double[dataLength - (int)(beginX / timeInterval)];
                    for (int i = (int)(beginX / timeInterval); i < dataLength; i++)
                    {
                        zoomYdata[k] = Ydata[i];
                        zoomXdata[k] = Xdata[i];
                        k++;
                    }
                }
            }
            else//放大起始点在切除点之后
            {
                if ((int)(begin / timeInterval) + zoomdataLength <= dataLength)//第二个波形放大长度没超过结尾
                {
                    int k = 0;
                    zoomXdata = new double[zoomdataLength];
                    zoomYdata = new double[zoomdataLength];
                    for (int i = (int)(begin / timeInterval); i < (int)(begin / timeInterval) + zoomdataLength; i++)
                    {
                        zoomYdata[k] = Ydata[i];
                        zoomXdata[k] = Xdata[i];
                        k++;
                    }
                }
                else//超过结尾
                {
                    int k = 0;
                    zoomXdata = new double[dataLength - (int)(begin / timeInterval)];
                    zoomYdata = new double[dataLength - (int)(begin / timeInterval)];
                    for (int i = (int)(begin / timeInterval); i < dataLength; i++)
                    {
                        zoomYdata[k] = Ydata[i];
                        zoomXdata[k] = Xdata[i];
                        k++;
                    }
                }
            }
        }
        private void 光标前置零ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //重绘tchart1
            tChart1.Series[0].Clear();
            setZeroFunc(mouseMoveX);
            operatorSort.Add(new double[2] { mouseMoveX, -1.0 });
            tChart1.Series[0].Add(Xdata, Ydata);
            //重绘tchart2
            tChart2.Series[0].Clear();
            tChart2.Series[0].Add(zoomXdata, zoomYdata);
        }

        private void 切除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutFlag = true;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            applyName.Clear();
            foreach (TreeNode pNode in treeView1.Nodes)//遍历所有父节点
            {
                if (pNode.Checked)//父节点被选中
                {
                    foreach (TreeNode node in pNode.Nodes)
                    {
                        applyName.Add(node.Text);
                    }
                }
                else//父节点未被选中
                {
                    foreach (TreeNode node in pNode.Nodes)
                    {
                        if (node.Checked)
                        {
                            applyName.Add(node.Text);
                        }
                    }
                }
            }
            applyName = applyName.Distinct().ToList<string>();//去重
        }
        //显示选中的动画和下标值
        private void tChart1_MouseMove(object sender, MouseEventArgs e)
        {
            double tmpX=tChart1.Series[0].XScreenToValue(e.X);
            mouseMoveX = tmpX;
            if (chooseFlag)
            {
                bannerTool1.Active = true;
                if (e.X <= 600)
                {
                    bannerTool1.Left = 600;
                }
                if (e.X >= tChart1.Left + tChart1.Width - 400)
                {
                    bannerTool1.Left = tChart1.Left + tChart1.Width - 400;
                }
                else
                {
                    bannerTool1.Left = e.X;
                }
                bannerTool1.Top = 180;
                double axis=(tmpX / timeInterval);
                if (tmpX <= 0.0)
                {
                    axis = 0.0;
                    tmpX = 0;
                }
                if (axis >= dataLength - 1)
                {
                    tmpX = (dataLength - 1) * timeInterval;
                    axis = dataLength - 1;
                }
                bannerTool1.Text = "时间：" + (tmpX).ToString("0.0000") + "秒\n幅值：" + Ydata[(int)axis].ToString();
                colorBand1.End = tChart1.Series[0].XScreenToValue(e.X);
            }
            else 
            {
                colorBand1.Start = 0;
                colorBand1.End = 0;
                bannerTool1.Active = false;
            }  
        }

        private void tChart2_Click(object sender, EventArgs e)
        {

        }   
    }
}
