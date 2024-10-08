function convertMe() {
    const input = document.getElementById('name').value;
    const output = document.getElementById('outputName');
    
    const isValidLength = input.length >= 4 && input.length <= 8;
    
    if (isValidLength) {
        output.value = input.toUpperCase();
    } else {
        alert('Name must be between 4 and 8 characters.');
    }
}

document.getElementById('convertButton').addEventListener('click', convertMe);
