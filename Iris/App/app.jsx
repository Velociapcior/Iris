import React from "react";
import { Route, Switch } from "react-router-dom";
import  Layout  from "./Components/layout.jsx";
import  Home  from "./Components/home.jsx";

const App = () => (
    <Layout>
        <Route exact path="/" component={Home}/>
    </Layout>);

export default App;