<template>
     <div class="container">
    <h3 class="text-center mb-4 mt-4">Lista Uzytkownikow</h3>
    <div class="container">
    <table class="table">
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
        </div>
        21
        </div>
</template>
    <script>
        import UsersService from "@/service/UsersService";
        export default {
        name: "UserList",
        data() {
        return {
    users: [],
    };
    },
        methods: {
        getUsers() {
        UsersService.getUsers()
        .then(response => {
        this.users = response.data;
 });
    }
     },
 created() {
 this.getUsers();
 }
};
</script>
<style>
</style>
