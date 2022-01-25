using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Baryshev14GlavaSProg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            {
                TreeNode tempNode;
                // Добавляем к дереву нейтральные культуры, как корневые узлы
                foreach (CultureInfo CultureX in CultureInfo.
                GetCultures(CultureTypes.NeutralCultures))
                {
                    tempNode = new TreeNode(CultureX.EnglishName
                    + " [" + CultureX.Name + "]");
                tempNode.Tag = CultureX;
                    treeView1.Nodes.Add(tempNode);
                }
                // Перебираем все конкретные культуры и добавляем
                // каждую из них к родительской нейтральной культуре в дереве
                foreach (CultureInfo CultureX in
                CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                {
                    foreach (TreeNode NodeX in treeView1.Nodes)
                    {
                        if (NodeX.Tag.Equals(CultureX.Parent))
                        {
                            tempNode = new TreeNode(CultureX.EnglishName
                            + " [" + CultureX.Name + "]");
                            tempNode.Tag = CultureX;
                            tempNode.ForeColor = Color.Red;
                            foreach (CultureInfo CultureY in CultureInfo.GetCultures(
                            CultureTypes.InstalledWin32Cultures))
                            {
                                if (CultureY.Equals(CultureX))
                                {
                                    tempNode.ForeColor = Color.Black;
                                    break;
                                }
                            }
                            NodeX.Nodes.Add(tempNode);
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form3 = new Form3();
            Form3.Show();
        }
    }
}
