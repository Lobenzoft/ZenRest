using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Metro.ColorTables;

namespace ZenResturant
{
    public partial class Inicio : MetroForm
    {
        public static Panel ContenidoP;
        public static string wifi = "0";
        public Inicio()
        {
            InitializeComponent();
            StyleManager.MetroColorGeneratorParameters = new MetroColorGeneratorParameters(Color.White, Color.FromArgb(46, 204, 250));
            MenuPanel.Controls.Clear();
            Menu menu = new Menu();
            menu.Dock = DockStyle.Fill;
            MenuPanel.Controls.Add(menu);
            ContenidoP = ContenidoPanel;
            ContenidoPanel.BackColor = Color.White;

        }
        public static void cambiarwifi(string _wifi)
        {
            wifi = _wifi;
        }
        public static string cambiarwifi()
        {
            return wifi;
        }

        public static void Cargarf(Control cont)
        {
            ContenidoP.Controls.Clear();
            ContenidoP.Controls.Add(cont);
        }
    }
}
