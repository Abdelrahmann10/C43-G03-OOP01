using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    // What can we write inside the namespace ?
    //1- Class
    //2- Struct (stands for structure)
    //3- Interface
    //4- Enum
   //-------------------------------------------
   // Allowed Access Modifires inside namespace
    //1- Internal (Default Access Modifiers)
    //2- Public
    public class TypeA
    {
        /*private*/ int x;
        internal int y;
        public int z;



        #region Definitions
        //What you can write inside the class or struct
        //1- Attribute (field* variable)
        //2- Property (FullProperty - Automatic Property - Indexer)
        //3- Functions (Cinstructor - Getter/Setter - Method)
        //4- Events
        //-----------------------------------
        //Allowed Access Modifires in Struct
        //1- Private
        //2- Internal
        //3- Public
        //----------------------------------
        //Allowed Access Modifires in Class
        //1- Private
        //2- Private Protected
        //3- Protected
        //4- Internal
        //5- Internal Protected
        //6- Public
        //----------------------------------
        //What you can write inside the interface
        //1- Signature for Property
        //2- Signature for Method
        //3- Default Impelemented Method
        //----------------------------------
         //Default Access Modifires inside the interface is Public
        #endregion
    }
}
