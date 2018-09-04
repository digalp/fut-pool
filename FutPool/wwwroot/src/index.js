//import $ from 'jquery';
import Vue from 'vue';
import App from './App.vue'
//import VueRouter from 'vue-router';
//import { getData, addTeam } from './service.js';

Vue.config.productionTip = false

//let saveTeam = addTeam;
// $('#add-team-btn').click(function (e) {
//     e.preventDefault();
//     let teamName = $('#add-team-text').val();
//     addTeam(teamName).done(getData);
// })


// $(document).ready(function () {
//     getData();
// });

new Vue({
    el: '#app',
    template: '<App/>',
    components: { App }
});

if (module.hot) {
    module.hot.accept();
}