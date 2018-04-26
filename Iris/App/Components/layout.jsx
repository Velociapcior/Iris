import React from "react";
import { Link, Switch } from "react-router-dom";

class Layout extends React.Component {

    render() {
        return (
            <div>
                <div>
                    <Link to='/'>Home</Link>
                </div>
                <div className="container">
                    <Switch>
                        {this.props.children}
                    </Switch>
                </div>
            </div>
        );
    }
}

export default Layout;