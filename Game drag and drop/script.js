const draggableContainer = document.querySelector('.draggableContainer');
const droppableContainer = document.querySelector('.droppableContainer');
const remarks = document.getElementById('remarks');
const scores = document.getElementById('scores');
const resetBtn = document.getElementById('resetBtn');

let score = 0;

// Questions and Answers
const questionsAndAnswers = [
    { id: 'box1', question: '1 + 1 = ?', answer: '2' },
    { id: 'box2', question: '2 + 2 = ?', answer: '4' },
    { id: 'box3', question: '1 + 4 = ?', answer: '5' },
    { id: 'box4', question: '10 + 10 = ?', answer: '20' },
    { id: 'box5', question: '12 + 12 = ?', answer: '24' },
    { id: 'box6', question: '7 + 8 = ?', answer: '15' },
    { id: 'box7', question: '10 + 20 = ?', answer: '30' },
    { id: 'box8', question: '4 + 17 = ?', answer: '21' },
    { id: 'box9', question: '8 + 10 = ?', answer: '18' },
    { id: 'box10', question: '5 + 5 = ?', answer: '10' },
];



// Shuffle array
function shuffle(array) {
    return array.sort(() => Math.random() - 0.5);
}

// Create draggable and droppable elements
function createGameElements() {
    draggableContainer.innerHTML = '';
    droppableContainer.innerHTML = '';

    const shuffledQuestions = shuffle([...questionsAndAnswers]);

    // Add all questions to the draggable container
    shuffledQuestions.forEach(item => {
        const box = document.createElement('div');
        box.classList.add('box');
        box.setAttribute('draggable', 'true');
        box.setAttribute('id', item.id);
        box.innerText = item.question;
        draggableContainer.appendChild(box);
    });

    // Add all answers to the droppable container (matching number of questions)
    const shuffledAnswers = shuffle([...questionsAndAnswers.map(item => item.answer)]);
    shuffledAnswers.forEach(answer => {
        const dropZone = document.createElement('div');
        dropZone.classList.add('droppable');
        dropZone.setAttribute('data-answer', answer);
        dropZone.innerText = answer;
        droppableContainer.appendChild(dropZone);
    });
}


// Initialize drag and drop functionality
function initializeDragAndDrop() {
    const draggableElements = document.querySelectorAll('.box');
    const droppableElements = document.querySelectorAll('.droppable');

    draggableElements.forEach(element => {
        element.addEventListener('dragstart', event => {
            event.dataTransfer.setData('text', event.target.id);
        });
    });

    droppableElements.forEach(element => {
        element.addEventListener('dragover', event => {
            event.preventDefault();
        });

        element.addEventListener('drop', event => {
            const draggedElementId = event.dataTransfer.getData('text');
            const draggedElement = document.getElementById(draggedElementId);
            const answer = questionsAndAnswers.find(item => item.id === draggedElementId).answer;

            if (element.getAttribute('data-answer') === answer) {
                element.appendChild(draggedElement);
                score++;
                remarks.innerText = "Correct! 🎉";
                scores.innerText = score;

                if (score === questionsAndAnswers.length) {
                    remarks.innerText = "You won! 🎊";
                }
            } else {
                remarks.innerText = "Oops! Try again. ❌";
            }
        });
    });
}

// Reset Game
function resetGame() {
    score = 0;
    remarks.innerText = '';
    scores.innerText = score;
    createGameElements();
    initializeDragAndDrop();
}

// Initialize Game
resetGame();

// Reset button functionality
resetBtn.addEventListener('click', resetGame);
