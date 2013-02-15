using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeCharSet
{
    class Encode
    {
         //编写构造函数

        public Encode(int id, string name)

   {

       this.Id = id;

       this.Name = name;

   }

   public int Id

   {

       get;

       set;

   }

 

   public string Name

   {

       get;

       set;

   }

   public override string ToString()

   {

       return this.Name;

   }
    }
}
