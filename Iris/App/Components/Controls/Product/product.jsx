import React from "react";

export class Product extends React.Component {
    constructor(props) {
        super(props);

        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() {
        this.props.onClick(this.props.store.productId);
    }

    render() {
        return <div id={this.props.store.productId} className="card">
            <header className="card-header has-background-info">
                <p className="card-header-title has-text-white is-4">{this.props.store.name}</p>
                <div className="card-header-icon">
                    <figure className="image is-48x48">
                        <img src={this.props.store.pictureUrl} alt="Img" />
                    </figure>
                </div>
            </header>
            <div className="card-content">
                <div className="content">
                    {this.props.store.description}
                </div>
                <div className="level">
                    <div className="level-left">
                        <button className="button is-danger" onClick={this.handleClick}>Usuń</button>
                    </div>
                    <div className="level-right">
                        {"Cena: "}
                        <b>{" " + this.props.store.price}</b>
                    </div>
                </div>
            </div>
        </div >;
    }
}