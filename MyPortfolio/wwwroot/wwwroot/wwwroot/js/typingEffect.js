const roles = [
  "Software Developer",
  "Cybersecurity Engineer",
  "Writer",
  "Musician",
  "Teacher",
  "Full Stack Developer",
  "Back End Engineer",
  "Ruby on Rails Developer"
];

let currentRoleIndex = 0;
let currentCharIndex = 0;
let isDeleting = false;
const baseTypingSpeed = 100;
const baseErasingSpeed = 50;
const delayBetweenRoles = 1500;

function getRandomSpeed(baseSpeed) {
  return baseSpeed + Math.floor(Math.random() * 50); // Adds a random 0-50 ms variation
}

function typeEffect() {
  const roleText = document.getElementById("role-text");

  if (!roleText) {
      // Retry if the element isn't loaded yet
      setTimeout(typeEffect, 100);
      return;
  }

  const currentRole = roles[currentRoleIndex];

  if (isDeleting) {
      roleText.textContent = currentRole.substring(0, currentCharIndex--);
      if (currentCharIndex < 0) {
          isDeleting = false;
          currentRoleIndex = (currentRoleIndex + 1) % roles.length;
          setTimeout(typeEffect, getRandomSpeed(baseTypingSpeed));
      } else {
          setTimeout(typeEffect, getRandomSpeed(baseErasingSpeed));
      }
  } else {
      roleText.textContent = currentRole.substring(0, currentCharIndex++);
      if (currentCharIndex > currentRole.length) {
          isDeleting = true;
          setTimeout(typeEffect, delayBetweenRoles);
      } else {
          setTimeout(typeEffect, getRandomSpeed(baseTypingSpeed));
      }
  }
}

// Start the typing effect
typeEffect();
