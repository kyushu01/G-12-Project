function convertHpToKw() {
    const hp = parseFloat(document.getElementById('hp').value);  
    const kwOutput = document.getElementById('kw');  

    
    if (!isNaN(hp) && hp > 0) {
        const kw = (hp * 0.7457).toFixed(2);  
        kwOutput.value = `${kw} kW`;  
    } else {
        alert('Please enter a valid horsepower value greater than 0.');
    }
}

document.getElementById('convertButton').addEventListener('click', convertHpToKw);
