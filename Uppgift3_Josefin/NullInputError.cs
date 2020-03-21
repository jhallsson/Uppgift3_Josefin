namespace Uppgift3_Josefin
{
    internal class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "You left the text-field empty. This fired an error!";
        }
        
    }
}