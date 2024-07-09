window.updateRangeBackground = (selector, percentage) => {
    const range = document.querySelector(selector);
    range.style.background = `linear-gradient(to right, #e53e3e 0%, #e53e3e ${percentage}%, #f3f4f6 ${percentage}%, #f3f4f6 100%)`;
};