using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Player
    {
        public int Id { get; set; }           
        public string Name { get; set; }       
        public string Team { get; set; }      
        public string PlayerPhoto { get; set; }  
        public double PointsPerGame { get; set; }       
        public double ReboundsPerGame { get; set; }       
        public double AssistsPerGame { get; set; }     
        public double StealsPerGame { get; set; }      
    }


}
