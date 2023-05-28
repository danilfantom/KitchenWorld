using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace itchenWorld
{
    public class Class1
    {
        Dictionary<string, string[]> Post = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"КодСотрудника","КодПомещения" } },
            { "Header" , new string[] {"Код сотрудника","Код помещения" } }
            
        };
        void main()
        {
            string[] temp = Post["Fields"];
        }
        
    }
}
