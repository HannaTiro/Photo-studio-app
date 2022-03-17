using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.Studio
{
    public partial class frmPregledStudija : Form
    {
        private readonly APIService _serviceStudio = new APIService("Studio");
       
        public frmPregledStudija()
        {
            InitializeComponent();
        }
      
        private async  void frmPregledStudija_Load(object sender, EventArgs e)
        {
            var result = await _serviceStudio.Get<List<Data.Model.Studio>>(null);
            dgvStudio.AutoGenerateColumns = false;
            dgvStudio.DataSource = result;
        }
    }
}
