import { Address } from "./address.model"

export type User = {
    id: number,
    firstName: string,
    lastName: string,
    email: string,
    address?: Address
}