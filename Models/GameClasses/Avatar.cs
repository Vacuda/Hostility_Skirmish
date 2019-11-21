
namespace Hostility_Skirmish.Models.GameClasses
{
    public class Avatar
    {

        



        //Point to Animation

        //this will house the Name of the character chosen and the animations and images associated with it
        //I think all of this info will be static, not customizable.





        
        //  ~/images/#.png






        public static string GetAvatar(string code){

            if (code == "~/images/1.png"){
                return "Brian";
            }
            if (code == "~/images/2.png"){
                return "Yarn";
            }
            if (code == "~/images/3.png"){
                return "Amber";
            }
            if (code == "~/images/4.png"){
                return "Scott";
            }
            if (code == "~/images/6.png"){
                return "Chris";
            }
            if (code == "~/images/7.png"){
                return "Brandon";
            }
            if (code == "~/images/8.png"){
                return "Adam";
            }
            if (code == "~/images/9.png"){
                return "Patty";
            }
            if (code == "~/images/10.png"){
                return "Steve";
            }
            if (code == "~/images/11.png"){
                return "Andy";
            }
            if (code == "~/images/12.png"){
                return "Chuck";
            }
            if (code == "~/images/13.png"){
                return "Adrien";
            }

            return "FALSE";
        }















    }
}