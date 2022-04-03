import { User } from "./user";

export interface UserResponse{
    accessToken: string,
    expiration: string,
    user: User
}