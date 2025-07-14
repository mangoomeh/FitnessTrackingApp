function showConfirm(id) {
    document.getElementById(`delete-${id}`).style.display = 'none';
    document.getElementById(`confirm-${id}`).style.display = 'block';
}

function hideConfirm(id) {
    document.getElementById(`delete-${id}`).style.display = 'block';
    document.getElementById(`confirm-${id}`).style.display = 'none';
}

function deleteItem(id) {
    fetch(`/Fitness/Delete/${id}`, {
        method: 'DELETE',
        headers: {
            'X-Requested-With': 'XMLHttpRequest'
        }
    }).then(response => {
        if (response.ok) {
            document.getElementById(`item-${id}`).remove();
        } else {
            alert('Error deleting item');
        }
    })
};