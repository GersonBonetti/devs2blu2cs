﻿using Devs2Blu.ProjetosAula.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Nlu.ProjetosAula.AulaOOPIntro
{
    public partial class Form1 : Form
    {

        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DirectorsList { get; set; }
        
            
        public Form1()
        {
            InitializeComponent();
        }
    }
}
