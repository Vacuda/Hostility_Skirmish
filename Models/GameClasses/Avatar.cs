
namespace Hostility_Skirmish.Models.GameClasses
{
    public class Avatar
    {

        



        //Point to Animation

        //this will house the Name of the character chosen and the animations and images associated with it
        //I think all of this info will be static, not customizable.








        public static string GetAvatar(string code){

            if (code == "/images/1.png"){
                return "Hosenbane";
            }
            if (code == "/images/2.png"){
                return "Argenian";
            }
            if (code == "/images/3.png"){
                return "Jasper";
            }
            if (code == "/images/4.png"){
                return "Pitter";
            }
            if (code == "/images/6.png"){
                return "Orgon";
            }
            if (code == "/images/7.png"){
                return "Kater";
            }
            if (code == "/images/8.png"){
                return "Arsen";
            }
            if (code == "/images/9.png"){
                return "Strike";
            }
            if (code == "/images/10.png"){
                return "Mango";
            }
            if (code == "/images/11.png"){
                return "Daphne";
            }
            if (code == "/images/12.png"){
                return "Portisha";
            }
            if (code == "/images/13.png"){
                return "Gheen";
            }

            return "FALSE";
        }















    }
}