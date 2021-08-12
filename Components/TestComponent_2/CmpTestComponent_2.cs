
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace BlazorWasmNetlify.Components.TestComponent_2 {
    public partial class CmpTestComponent_2 {
        #region Fields

        #endregion (Fields)

        #region Methods

        #endregion (Methods)

        #region Properties
        [Parameter]
        public int test_num { get; set; }

        [Parameter]
        public EventCallback<int> test_numChanged { get; set; }

        async Task Update_Test_Num(int tiValue) {
            await test_numChanged.InvokeAsync(tiValue);
        }
        //[Parameter]
        //public EventCallback On_Test_Switch_Changed { get; set; }
        #endregion (Properties)
        //protected async Task DoneButtonClicked() {
        //    //await testcall.InvokeAsync();
        //}
    }
}
