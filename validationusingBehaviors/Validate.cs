     private void Validate (Entry entry, string newTextValue) {
             if (!entry.IsVisible || !entry.IsEnabled) {
                 SetDefaultValidate (entry);
                 return;
             }

             if (IsCheckEmpty) {
                 IsValid = ValidatorsFactory.IsValidEmpty (newTextValue);
                 Message = Messages.FieldCannotBlank;
                 if (!IsValid) {
                     entry.TextColor = Color.Red;
                     return;
                 }
             }
             if (IsCheckEmail) {
                 IsValid = ValidatorsFactory.IsValidEmail (newTextValue);
                 Message = Messages.EmailIncorrectFormat;
                 if (!IsValid) {
                     entry.TextColor = Color.Red;
                     return;
                 }
             }
             if (IsCheckNumber) {
                 IsValid = ValidatorsFactory.IsValidNumber (newTextValue);
                 Message = Messages.PleaseInputNumber;
                 if (!IsValid) {
                     entry.TextColor = Color.Red;
                     return;
                 }
             }
             if (IsCheckTelephone) {
                 IsValid = ValidatorsFactory.IsValidTelephone (newTextValue);
                 Message = Messages.TelephoneIncorrectFormat;
                 if (!IsValid) {
                     entry.TextColor = Color.Red;
                     return;
                 }
             }

             if (MinLength > 0) {
                 IsValid = ValidatorsFactory.IsValidMinLength (newTextValue, MinLength);
                 Message = Messages.MinimizeLengthIs + MinLength;
                 if (!IsValid) {
                     entry.TextColor = Color.Red;
                     return;
                 }
             }

             if (MaxLength > 0) {
                 IsValid = ValidatorsFactory.IsValidMaxLength (newTextValue, MaxLength);
                 Message = Messages.MaximizeLengthIs + MaxLength;
                 if (!IsValid) {
                     entry.TextColor = Color.Red;
                     return;
                 }
             }

             if (MinValue > 0) {
                 IsValid = ValidatorsFactory.IsValidMinValue (newTextValue, MinValue);
                 Message = Messages.MinimizeLengthIs + MinValue;
                 if (!IsValid) {
                     entry.TextColor = Color.Red;
                     return;
                 }
             }

             if (MaxValue > 0) {
                 IsValid = ValidatorsFactory.IsValidMaxValue (newTextValue, MaxValue);
                 Message = Messages.MinimizeValueIs + MaxValue;
                 if (!IsValid) {
                     entry.TextColor = Color.Red;
                     return;
                 }
             }
             //TODO: add more validation

             //Default
             SetDefaultValidate (entry);