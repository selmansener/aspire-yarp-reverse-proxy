import { Link } from "react-router-dom";

export function AnotherPage() {

    return <div>
        <h1>This is another page</h1>
        <div>
            <Link to="/dashboard/some-page">Navigate to some page</Link>
        </div>
        <div>
            <Link to="/dashboard">Navigate to dashboard</Link>
        </div>
    </div>
}