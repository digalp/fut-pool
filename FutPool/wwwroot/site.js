import { getData, addTeam } from './service.js';

//let saveTeam = addTeam;
$('#add-team-btn').click(function (e) {
    e.preventDefault();
    let teamName = $('#add-team-text').val();
    addTeam(teamName).done(getData);
})


$(document).ready(function () {
    getData();
});