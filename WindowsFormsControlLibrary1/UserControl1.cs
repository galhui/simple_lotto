using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        List<int> ExceptNumber = new List<int>();

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            ExceptNumber.Clear();
            txtCreate.Text = String.Empty;
            txtExcept.Text = String.Empty;

            MakeExceptNumbers(int.Parse(this.numExcept.Value.ToString()));
            MakeRealNumbers(int.Parse(this.numCreate.Value.ToString()));
        }

        public void MakeExceptNumbers(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                List<int> sixNum = GetSixNumber();
                sixNum.Sort();

                foreach(int a in sixNum)
                {
                    if (!ExceptNumber.Contains(a))
                        ExceptNumber.Add(a);
                }

                txtExcept.Text += ListToString(sixNum) + "\r\n";
            }
        }

        public void MakeRealNumbers(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                List<int> sixNum = GetSixNumber(ExceptNumber);
                sixNum.Sort();
                
                txtCreate.Text += ListToString(sixNum) + "\r\n";
            }
        }

        public int GetRandomNumber()
        {
            Random r = new Random();

            return r.Next(1, 45);
        }

        public List<int> GetSixNumber(List<int> excepNum)
        {
            List<int> ret = new List<int>();

            while (ret.Count != 6)
            {
                int addNum = GetRandomNumber();
                if (!ret.Contains(addNum) && !excepNum.Contains(addNum))
                    ret.Add(addNum);
            }

            return ret;
        }

        public List<int> GetSixNumber()
        {
            List<int> ret = new List<int>();

            while( ret.Count!=6 )
            {
                int addNum = GetRandomNumber();
                if (!ret.Contains(addNum))
                    ret.Add(addNum);
            }

            return ret;
        }

        public string ListToString(List<int> list)
        {
            string ret = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                ret += list[i] + ", ";
            }

            return ret.Substring(0, ret.Length - 2);
        }
    }
}
