const uri = 'api/futpool'

function getData() {
    return $.get(uri, function (data) {
        $('#output').text(JSON.stringify(data));
    }).fail(function () {
        alert('getData failed');
    });
}

function addTeam(teamName) {
    const item = {
        'name': teamName
    };

    return $.post(uri, item, function (result) {
        $('#add-team').val('');
    }).fail(function () {
        console.error('addTeam failed');
    });
}

export { getData, addTeam };