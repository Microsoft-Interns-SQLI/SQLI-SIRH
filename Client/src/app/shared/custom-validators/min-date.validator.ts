/**
 * this is a custome validator form checking dates validation e.g ('start_date' must be lower than 'end_date')
 * code inspired from : https://gist.github.com/maxdhn/1aadcd4a99e7b6a4435dc714f551deda
 */
import { AbstractControl, ValidatorFn, ValidationErrors } from "@angular/forms";

/**
 * Check if control value is inferior to date in parameter
 * @export
 */
export function minDateValidator(minDate: Date): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    // parse control value to Date
    const date = new Date(control.value);
    // check if control value is superior to date given in parameter
    if (minDate.getTime() < date.getTime()) {
      return null;
    } else {
      return { 'min': { value: control.value, expected: minDate } };

    }
  };
}