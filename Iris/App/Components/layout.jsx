import React from "react";
import { Link, Switch } from "react-router-dom";

class Layout extends React.Component {

    render() {
        return (
            <div>
                <nav className="navbar has-background-light" role="navigation">
                    <Link className="navbar-item" to='/'>Home</Link>
                </nav>
                <div className="container">
                    <Switch>
                        {this.props.children}
                    </Switch>
                </div>
            </div>
        );
    }
}

export default Layout