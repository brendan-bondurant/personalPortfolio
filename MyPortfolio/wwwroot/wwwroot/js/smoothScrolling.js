document.addEventListener('DOMContentLoaded', function () {
  document.querySelectorAll('a.nav-link').forEach(anchor => {
      anchor.addEventListener('click', function (e) {
          const target = document.querySelector(this.getAttribute('href'));
          if (target) {
              e.preventDefault();
              target.scrollIntoView({ behavior: 'smooth' });
          }
      });
  });
});