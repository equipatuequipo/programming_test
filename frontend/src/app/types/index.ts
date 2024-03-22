import type { FormControl } from '@angular/forms';

export { Customer } from './customer';

/**
 * This type allows for better type inference in Angular's FormGroups.
 *
 * @example new FormGroup<ControlsOf<CustomerCreate>>({
 * 		// Form fields
 * })
 */
export type ControlsOf<T> = {
	[K in keyof T]: FormControl<T[K]>;
};
