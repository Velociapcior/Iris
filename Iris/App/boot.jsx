import 'bulma/css/bulma.css';
import './Content/Styles/site.less';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './app.jsx';

function renderApp() {
    console.log();

    ReactDOM.render((
        <BrowserRouter basename={location.pathname}>
                <App />
        </BrowserRouter>
        ),
        document.getElementById('root'));
}

renderApp();