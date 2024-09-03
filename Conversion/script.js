function convertHPtoKW() {
    const hpValue = document.getElementById('hpValue').value;
    if (hpValue) {
        const kwValue = (hpValue * 0.735499).toFixed(2);
        document.getElementById('result').textContent = `${hpValue} HP is equal to ${kwValue} KW.`;
    } else {
        document.getElementById('result').textContent = "Please enter a valid HP value.";
    }
}
