function convertMe() {
    const hpInput = document.getElementById('hp').value;
    const kwOutput = document.getElementById('kw');
    
    
    if (hpInput !== '') {
        const hp = parseFloat(hpInput); 
        
        if (!isNaN(hp) && hp > 0) {
            const kw = (hp * 0.7457).toFixed(2); 
            kwOutput.value = kw; 
        } else {

            alert('Please enter a valid HP value greater than 0.');
        }
    } else {
      
        alert('Please enter a value for HP.');
    }
}


document.getElementById('convertButton').addEventListener('click', convertMe);

document.getElementById('resetButton').addEventListener('click', () => {
    document.getElementById('kw').value = '';
});