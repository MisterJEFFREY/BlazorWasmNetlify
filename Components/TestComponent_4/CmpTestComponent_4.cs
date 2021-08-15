using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using Microsoft.JSInterop;

namespace BlazorWasmNetlify.Components.TestComponent_4 {
    public partial class CmpTestComponent_4 {


        #region Fields
        public string _contactName;
        public string _contactEmail;
        public string _contactSubject;
        public string _contactMessage;
        #endregion (Fields)


        #region Methods
        //THIS WORKS AS INTENDED! NO NEED TO PASS FROM PARENT TO CHILD COMPONENT!!
        protected override void OnInitialized() {
            currentUrl = NavigationManager.Uri;
        }
        //private async void FormDataTest() {
        //    await JS.InvokeAsync<object>("AccessFORMDATA");
        //}

        async Task Update_Test_Num(int tiValue) {
            //string Log; 
            //Log = System.Text.Json.JsonSerializer.Serialize(testformref) + "\r\n";
            //Check if all input fields are not empty
            if (!String.IsNullOrEmpty(ContactName) && !String.IsNullOrEmpty(ContactEmail) 
                && !String.IsNullOrEmpty(ContactSubject) && !String.IsNullOrEmpty(ContactMessage))
                {
                    ContactFormSubmitText = "Loading";
                    ContactFormSubmitted = true;
                    //It feels like the form data is sent a lil slower than anticipated...
                    await Task.Delay(5000); //Will this allow the data to be sent before changing components?
                    await test_numChanged.InvokeAsync(tiValue);
                }
        }

        public void On_ContactNameChanged(string tsInput) {
            _contactName = tsInput;
        }
        
        public void On_ContactEmailChanged(string tsInput) {
            _contactEmail = tsInput;
        }

        public void On_ContactSubjectChanged(ChangeEventArgs tsInput) {
            _contactSubject = tsInput.Value.ToString();
        }

        public void On_ContactMessageChanged(string tsInput) {
            _contactMessage = tsInput;
        }

        #endregion (Methods)


        #region Properties
        public string currentUrl { get; set; }


        [Parameter]
        public int test_num { get; set; }

        [Parameter]
        public EventCallback<int> test_numChanged { get; set; }

        public bool ContactFormSubmitted { get; set; } = false;
        public string ContactFormSubmitText { get; set; } = "Submit";
        //See if this grabs values from the contact form and if we can do validations before sending data...
        public string ContactName { get => _contactName; set => On_ContactNameChanged(value); }
        public string ContactEmail { get => _contactEmail; set => On_ContactEmailChanged(value); }
        public string ContactSubject { get => _contactSubject; set => _contactSubject = value; }
        public string ContactMessage { get => _contactMessage; set => On_ContactMessageChanged(value); }
        //[Parameter]
        //ElementReference testformref;

        #endregion (Properties)

    }
}
