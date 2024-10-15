function searchData() {
    const searchInput = document.getElementById('search-input').value.trim();
    if (searchInput) {
        fetch(`https://wl-api.mf.gov.pl/api/search/nip/${searchInput}?date=2024-10-14&_=9999999999`)
            .then(response => response.text())
            .then(data => {
                const outputWindow = document.querySelector('.output-window');
				var outputData = JSON.parse(data);
				
                outputWindow.innerHTML = `<pre>${outputData.result.subject.name}</pre>`;
            })
            .catch(error => console.error('Error:', error));
    }
}