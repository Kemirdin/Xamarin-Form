 public void Validar (Object sender, EventArgs e) {
     var email = EntryEmail.Text;
     var emailPattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

     if (!String.IsNullOrWhiteSpace (email) && !(Regex.IsMatch (email, emailPattern))) {
         LabelError.Text = "EmailVerification Failed";
     } else {
         LabelError.Text = "";
     }
 }