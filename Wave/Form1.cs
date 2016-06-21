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
using System.Management;

/*
 * 2016.6.15
 * By wyc
 * Wave Painting
 * 文件管理单元。
 * win7（32，64位）。
 * 打开某些系统c盘文件遍历可能为空，可能是系统防火墙或360等。建议把文件放在c盘以外的地方
 */
//1234564112   
namespace Wave
{
    public partial class Form1 : Form
    {
        //全局变量区
        List<string> diskname = new List<string>();
        string rootDirectory;//根目录
        public static List<TreeNode> node = new List<TreeNode>();//treeview的节点信息，全局是为了在下一个窗体中调用
        public static List<string> directory = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //获取磁盘信息
            listHardView.Clear();
            treeHardView.Nodes.Clear();
            ManagementClass diskClass = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection disks = diskClass.GetInstances();
            foreach (ManagementObject disk in disks)
            {
                try
                {
                    comLocHard.Items.Add(disk["Description"].ToString() +"->"+ disk["name"].ToString() + "(余:" + (Convert.ToInt64(disk["FreeSpace"]) / 1048576).ToString() + "M)");
                    diskname.Add(disk["name"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示");
                }
            }
            //读文件，从file.dat文件获取上一次的用户文件目录
            FileStream fs;
            StreamReader sr;
            List<string> tmpname = new List<string>();
            try
            {
                fs = new FileStream("file.dat", FileMode.Open);
                sr = new StreamReader(fs);
                string tmp;
                while ((tmp = sr.ReadLine())!=null)
                {
                    tmpname.Add(tmp);
                }
                sr.Close();
                fs.Close();
            }
            catch { }
            for (int i = 0; i < tmpname.Count;i++ )
            {
                try
                {
                    string[] filename;

                    filename = Directory.GetFiles(rootDirectory + tmpname[i].TrimStart(' '), "*.txt");
                    node.Add(treeHardView.Nodes.Add(rootDirectory + tmpname[i].TrimStart(' ')));
                    directory.Add(rootDirectory + tmpname[i].TrimStart(' '));
                    for (int j = 0; j < filename.Length; j++)
                    {
                        node[node.Count - 1].Nodes.Add(filename[j]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        //选中一个磁盘，则更新listview的文件目录
        private void comLocHard_SelectedIndexChanged(object sender, EventArgs e)
        {
            listHardView.Clear();
            string[] listDirectory = Directory.GetDirectories(diskname[comLocHard.SelectedIndex].ToString());
            listHardView.Items.Add(diskname[comLocHard.SelectedIndex].ToString()+"\\");
            rootDirectory = diskname[comLocHard.SelectedIndex].ToString()+"\\";
            if (listDirectory != null)
            {
                for (int i = 0; i < listDirectory.Length; i++)
                {
                    listHardView.Items.Add(" " + listDirectory[i].Substring(2));
                }
            }
        }
        //双击文件目录时间
        private void listHardView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listHardView.SelectedIndices[0] == 0)//目录向上翻，表示回到上一目录
            {
                rootDirectory = rootDirectory.Remove(rootDirectory.LastIndexOf("\\"));
                listHardView.Clear();
                try
                {
                    if (rootDirectory.LastIndexOf("\\") != -1)//文件夹目录
                    {
                        listHardView.Items.Add(rootDirectory.Substring(rootDirectory.LastIndexOf("\\")+1));
                        rootDirectory = rootDirectory.Remove(rootDirectory.LastIndexOf("\\") + 1);
                    }
                    else//盘符目录
                    {
                        listHardView.Items.Add(rootDirectory + "\\");
                        rootDirectory += "\\";
                    }
                }
                catch { }
                string[] listDirectory = Directory.GetDirectories(rootDirectory);
                for (int i = 0; i < listDirectory.Length; i++)
                {
                    listDirectory[i] = listDirectory[i].Replace(rootDirectory, "");
                    listHardView.Items.Add(" " + listDirectory[i]);
                }
            }
            else//打开下面目录
            {
                string selectName = listHardView.SelectedItems[0].Text.TrimStart(' ');
                rootDirectory += (selectName + "\\");
                listHardView.Clear();
                listHardView.Items.Add(selectName);
                string[] listDirectory = Directory.GetDirectories(rootDirectory);
                for (int i = 0; i < listDirectory.Length; i++)
                {
                    listDirectory[i] = listDirectory[i].Replace(rootDirectory, "");
                    listHardView.Items.Add(" " + listDirectory[i]);
                }
            }
        }
        //按钮添加事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("file.dat", FileMode.OpenOrCreate);
            StreamWriter sw=new StreamWriter(fs);
            foreach (ListViewItem item in listHardView.CheckedItems)
            {
                try
                {
                    string[] filename;
                    if (rootDirectory.LastIndexOf(item.Text) == -1)
                    {
                        filename = Directory.GetFiles(rootDirectory + item.Text.TrimStart(' '),"*.txt");
                        sw.WriteLine(rootDirectory + item.Text.TrimStart(' '));
                        node.Add(treeHardView.Nodes.Add(rootDirectory + item.Text.TrimStart(' ')));
                        directory.Add(rootDirectory + item.Text.TrimStart(' '));
                    }
                    else
                    {
                        filename = Directory.GetFiles(rootDirectory, "*.txt");
                        sw.WriteLine(rootDirectory);
                        node.Add(treeHardView.Nodes.Add(rootDirectory));
                        directory.Add(rootDirectory);
                    }
                    for (int i = 0; i < filename.Length; i++)
                    {
                        node[node.Count - 1].Nodes.Add(filename[i]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                } 
            }
            sw.Close();
            fs.Close();
        }
        //去除选中文件
        private void treeHardView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            treeHardView.Nodes.Remove(treeHardView.SelectedNode);
        }
        //打开下一个窗体
        private void btnExport_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
