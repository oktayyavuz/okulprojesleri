const photos = [
    { src: "../resimler/altbanner1.png", caption: "Naofumi Discord Botu (Node.js)" },
    { src: "../resimler/altbanner2.png", caption: "VenCord Site Tasarımı (React.js)" },
    { src: "../resimler/altbanner3.png", caption: "Kişisel Portfolio Websitesi (React.js)" },
    { src: "../resimler/Rimuru.png", caption: "Rimuru Discord Botu (Node.js)" },
];

let currentPhotoIndex = 0;

const modal = document.getElementById("modal");
const modalImage = document.getElementById("modal-image");
const caption = document.getElementById("caption");
const thumbnail = document.querySelector(".thumbnail");
const closeModal = document.querySelector(".close");
const prevButton = document.getElementById("prev");
const nextButton = document.getElementById("next");

thumbnail.src = photos[currentPhotoIndex].src;

thumbnail.addEventListener("click", () => {
    openModal();
    updateModalContent();
}); 

function openModal() {
    modal.style.display = "flex"; 
    modal.classList.add('show');
}

function closeModalFunction() {
    modal.style.display = "none";
    modal.classList.remove('show');
}

thumbnail.addEventListener("click", () => {
    openModal();
    updateModalContent();
});

closeModal.addEventListener("click", () => {
    closeModalFunction();
});

window.addEventListener("click", (e) => {
    if (e.target === modal) {
        closeModalFunction();
    }
});



function updateModalContent() {
    modalImage.src = photos[currentPhotoIndex].src;
    caption.textContent = photos[currentPhotoIndex].caption;
}

prevButton.addEventListener("click", () => {
    currentPhotoIndex = (currentPhotoIndex - 1 + photos.length) % photos.length;
    updateModalContent();
});

nextButton.addEventListener("click", () => {
    currentPhotoIndex = (currentPhotoIndex + 1) % photos.length;
    updateModalContent();
});

window.addEventListener("click", (e) => {
    if (e.target === modal) {
        modal.style.display = "none";
    }
});


document.addEventListener('mousemove', (e) => {
    const buttons = document.querySelectorAll('.controls button');
    buttons.forEach((button) => {
        const rect = button.getBoundingClientRect();
        const distance = Math.sqrt(
            Math.pow(e.clientX - (rect.left + rect.width / 2), 2) +
            Math.pow(e.clientY - (rect.top + rect.height / 2), 2)
        );
        
        if (distance < 600) { 
            button.setAttribute('data-distance', 'near');
        } else {
            button.setAttribute('data-distance', 'far');
        }
    });
});



const banner = document.getElementById("banner");
let position = 0;
let lastPosition = 340; 
let negativeLimit = -300; 
let isHovered = false;
let direction = 1; 

function scrollBanner() {
    if (!isHovered) {
        position += 0.40 * direction;
        banner.style.backgroundPositionX = `${position}px`;

        if (position >= lastPosition) {
            direction = -1; 
        } else if (position <= negativeLimit) {
            direction = 1; 
        }
    }
    requestAnimationFrame(scrollBanner); 
}

banner.addEventListener("mouseenter", () => {
    isHovered = true; 
});

banner.addEventListener("mouseleave", () => {
    isHovered = false; 
});

scrollBanner(); 


