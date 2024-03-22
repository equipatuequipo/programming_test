export interface CustomerSelect {
	customerId: number;

	firstName: string;

	lastName: string;

	company: string | null;

	address: string | null;

	city: string | null;

	state: string | null;

	country: string | null;

	postalCode: string | null;

	phone: string | null;

	fax: string | null;

	email: string;
}

export interface CustomerCreate {
	firstName: string;

	lastName: string;

	company: string | null;

	address: string | null;

	city: string | null;

	state: string | null;

	country: string | null;

	postalCode: string | null;

	phone: string | null;

	fax: string | null;

	email: string;
}
