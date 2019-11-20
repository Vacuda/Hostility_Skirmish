
namespace Hostility_Skirmish.Models.GameClasses
{
    public class Avatar
    {

        



        //Point to Animation

        //this will house the Name of the character chosen and the animations and images associated with it
        //I think all of this info will be static, not customizable.





        







        public static string GetAvatar(string code){

            if (code == "char-1"){
                return "Brian";
            }
            if (code == "char-2"){
                return "Yarn";
            }
            if (code == "char-3"){
                return "Amber";
            }
            if (code == "char-4"){
                return "Scott";
            }
            if (code == "char-6"){
                return "Chris";
            }
            if (code == "char-7"){
                return "Brandon";
            }
            if (code == "char-8"){
                return "Adam";
            }
            if (code == "char-9"){
                return "Patty";
            }
            if (code == "char-10"){
                return "Steve";
            }
            if (code == "char-11"){
                return "Andy";
            }
            if (code == "char-12"){
                return "Chuck";
            }
            if (code == "char-13"){
                return "Adrien";
            }

            return "FALSE";
        }















    }
}