fetch('cars.json')
    .then(response => response.json())
    .then(data => {
        const container = document.getElementById('car-collection');
        
        data.forEach(car => {
            
            const card = document.createElement('div');
            card.classList.add('card');
            
            
            card.innerHTML = `
                <img src="images/${car.image}" alt="${car.name}">
                <h2>${car.name}</h2>
                <p>${car.description}</p>
                <p class="price">${car.price}</p>
            `;
            
            
            container.appendChild(card);
        });
    })
    .catch(error => console.error('Error loading JSON data:', error));