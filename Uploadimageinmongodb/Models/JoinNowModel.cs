using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uploadimageinmongodb.Models
{
    public class JoinNowModel
    {
         public string name { get; set; }
         public string email { get; set; }
         public string phoneno { get; set; }
         public string gender { get; set; }
         public string address { get; set; }
         public string city { get; set; }
         public string state { get; set; }
         public int zip { get; set; }
         public DateTime date { get; set; }
         public string messagebox { get; set;}

         public JoinNowModel()
         {
             date = DateTime.Now; 
         }
    }
}