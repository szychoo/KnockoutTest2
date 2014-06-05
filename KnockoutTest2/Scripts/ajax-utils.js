function ajaxAdd(url, dataToSave, callback) {
    ajaxModify(url, dataToSave, "post", "Person saved", callback);
}

function ajaxModify(url, dataToSave, httpVerb, successMessage, callback) {
    $.ajax(url, {
        data: dataToSave,
        type: httpVerb,
        dataType: 'json',
        contentType: 'application/json',
        success: function(data) {
            alert(successMessage);

            if (callback != null) {
                callback(data);
            };

            
        },
        error: function() {
            alert('unexpectedError');
    }
    });
}