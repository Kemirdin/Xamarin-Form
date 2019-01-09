      private void Validate (Entry entry, string newTextValue) {
              if (!entry.IsVisible || !entry.IsEnabled) {
                  SetDefaultValidate (entry);
                  return;
              }

              this.When (x => x.IsCheckEmpty)
                  .ValidateBy (() => ValidatorsFactory.IsValidEmpty (newTextValue))
                  .WithMessage (Messages.FieldCannotBlank)

                  .When (this, x => x.IsCheckEmail)
                  .ValidateBy (() => ValidatorsFactory.IsValidEmail (newTextValue))
                  .WithMessage (Messages.EmailIncorrectFormat)

                  .When (this, x => x.IsCheckNumber)
                  .ValidateBy (() => ValidatorsFactory.IsValidNumber (newTextValue))
                  .WithMessage (Messages.PleaseInputNumber)

                  .When (this, x => x.IsCheckTelephone)
                  .ValidateBy (() => ValidatorsFactory.IsValidTelephone (newTextValue))
                  .WithMessage (Messages.TelephoneIncorrectFormat)

                  .When (this, x => x.MinLength > 0)
                  .ValidateBy (() => ValidatorsFactory.IsValidMinLength (newTextValue, MinLength))
                  .WithMessage (Messages.MinimizeLengthIs + MinLength)

                  .When (this, x => x.MaxLength > 0)
                  .ValidateBy (() => ValidatorsFactory.IsValidMaxLength (newTextValue, MaxLength))
                  .WithMessage (Messages.MaximizeLengthIs + MaxLength)

                  .When (this, x => x.MinValue > 0)
                  .ValidateBy (() => ValidatorsFactory.IsValidMinValue (newTextValue, MinValue))
                  .WithMessage (Messages.MinimizeValueIs + MinValue)

                  .When (this, x => x.MaxValue > 0)
                  .ValidateBy (() => ValidatorsFactory.IsValidMaxValue (newTextValue, MaxValue))
                  .WithMessage (Messages.MaximizeValueIs + MaxValue)

                  .ApplyResult<EntryValidatorBehavior, Entry> (this);

              if (!IsValid) {
                  entry.TextColor = Color.Red;
                  return;
              }

              //Default
              SetDefaultValidate (entry);