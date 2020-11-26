<template>
     <div class="container">
    <h3 class="text-center mb-4 mt-4">Lista Chatu</h3>
    <div class="container">
    <!-- <table class="table">
    <thead>
     <tr>
    <th>Id</th>
    <th>Uzytkownik</th>
    </tr>
    </thead>
    <tbody>
    <tr v-for="users in users" v-bind:key="users.id">
    <td>{{ users.id }}</td>
    <td>{{ users.nickname }}</td>
    </tr>
    </tbody>
    </table>
                                                  TRZEBA ZROBIĆ DLA WŁASCIWOSCI CHATU
    -->
        </div>
        21
        </div>
</template>
    <script>
        import ChatService from "@/service/ChatService";
        export default {
        name: "ChatList",
        data() {
        return {
    chat: [],
    };
    },
        methods: {
        getChat() {
        ChatService.getChat()
        .then(response => {
        this.chat = response.data;
 });
    }
     },
 created() {
 this.getChat();
 }
};
</script>
<style>
</style>
