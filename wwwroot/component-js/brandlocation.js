﻿document.addEventListener('DOMContentLoaded', function () {
    const countrySelect = document.querySelector('.brandcountry');
    const stateSelect = document.querySelector('.brandstate');
    const citySelect = document.querySelector('.brandcity');

    // Fetch countries
    fetch('https://api.countrystatecity.in/v1/countries', {
        headers: {
            'X-CSCAPI-KEY': 'NHhvOEcyWk50N2Vna3VFTE00bFp3MjFKR0ZEOUhkZlg4RTk1MlJlaA=='
        }
    })
        .then(response => response.json())
        .then(data => {
            data.forEach(country => {
                const option = document.createElement('option');
                option.value = country.iso2;
                option.textContent = country.name;
                countrySelect.appendChild(option);
            });
        })
        .catch(error => console.error('Error loading countries:', error));

    // Fetch states
    countrySelect.addEventListener('change', function () {
        const countryCode = this.value;
        stateSelect.innerHTML = ''; // Clear previous options
        citySelect.innerHTML = ''; // Clear previous options

        fetch(`https://api.countrystatecity.in/v1/countries/${countryCode}/states`, {
            headers: {
                'X-CSCAPI-KEY': 'NHhvOEcyWk50N2Vna3VFTE00bFp3MjFKR0ZEOUhkZlg4RTk1MlJlaA=='
            }
        })
            .then(response => response.json())
            .then(data => {
                data.forEach(state => {
                    const option = document.createElement('option');
                    option.value = state.iso2;
                    option.textContent = state.name;
                    stateSelect.appendChild(option);
                });
            })
            .catch(error => console.error('Error loading states:', error));
    });

    // Fetch cities
    stateSelect.addEventListener('change', function () {
        const countryCode = countrySelect.value;
        const stateCode = this.value;
        citySelect.innerHTML = ''; // Clear previous options

        fetch(`https://api.countrystatecity.in/v1/countries/${countryCode}/states/${stateCode}/cities`, {
            headers: {
                'X-CSCAPI-KEY': 'NHhvOEcyWk50N2Vna3VFTE00bFp3MjFKR0ZEOUhkZlg4RTk1MlJlaA=='
            }
        })
            .then(response => response.json())
            .then(data => {
                data.forEach(city => {
                    const option = document.createElement('option');
                    option.value = city.name;
                    option.textContent = city.name;
                    citySelect.appendChild(option);
                });
            })
            .catch(error => console.error('Error loading cities:', error));
    });
});