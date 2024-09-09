function convertMe() {

    const input = document.getElementById('name').value;

    const output = document.getElementById('outputName');

    const isValidLength = input.length >= 4 && input.length <= 8;

    isValidLength ? output.value = input.toUpperCase() : alert('Name must be between 4 and 8 characters.');
}
document.getElementById('convertButton').addEventListener('click', convertMe)/*;function convertMe() {
    const input = document.getElementById('name').value;
    const output = document.getElementById('outputName');
    
    if (input.length >= 4 && input.length <= 8){
        output.value = input.toUpperCase();
    } else{
        alert('Name must be between 4 and 8 characters.');}
}