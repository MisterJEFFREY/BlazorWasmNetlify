using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace BlazorWasmNetlify.Pages {
    public partial class Index {


        #region Fields
        public int _test_Switch = 2;
        #endregion (Fields)


        #region Methods
        //protected override void OnParametersSet() {
        //    //_test_Switch = RecievedVal.Switch_To;
        //    //RecievedVal.SetCurrentPageName(Name);
        //}

        public void On_Test_Switch_Changed(int tiTestVal) {
            _test_Switch = tiTestVal;
        }
        #endregion (Methods)


        #region Properties
        [Parameter]
        public int Test_Switch { get => _test_Switch; set => On_Test_Switch_Changed(value); }
        //[Parameter]
        //public string Name { get; set; }
        #endregion (Properties)

    }
}
