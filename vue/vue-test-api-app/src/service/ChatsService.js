import axios from "axios";

const BASE_API_URL = "http://localhost:58546/api";
const USERS_API_URL = '$(BASE_API_URL)/chats';

class ChatsService {

  getchats(){

     return axios.get(CHATS_API_URL);
   }

 }

 export default new ChatsService();
