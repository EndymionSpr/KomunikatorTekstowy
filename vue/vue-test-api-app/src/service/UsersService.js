import axios from "axios";

const BASE_API_URL = "http://localhost:58546/api";
const USERS_API_URL = '$(BASE_API_URL)/users';

class UsersService {

  getUsers(){

     return axios.get(USERS_API_URL);
   }

 }

 export default new UsersService(); 
