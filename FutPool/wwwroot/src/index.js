import $ from 'jquery';
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

// if (module.hot) {
//     console.warn('module is hot');
//     module.hot.accept('./service.js', function () {
//         console.log('Accepting the updated service module!');
//     })
// }