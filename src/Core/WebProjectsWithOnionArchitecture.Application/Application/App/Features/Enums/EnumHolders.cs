using System.ComponentModel;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Features.Enums
{
    public static class EnumHolders
    {

        public enum ResponseMessages
        {
            [Description("Row(s) Added Successfully")] Added,
            [Description("Rows(s) Not Added")] Fail
        }
        public enum ResponseStatus
        {
            [Description("Successfully")] True,
            [Description("Unsuccessfully")] False
        }



    }

 
}
