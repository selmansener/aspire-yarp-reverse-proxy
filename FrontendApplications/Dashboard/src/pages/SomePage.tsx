import { Link } from "react-router-dom";

export function SomePage() {
    
    return <div>
        <h1>This is some page</h1>
        <Link to="/dashboard/another-page">Navigate to another page</Link>
    </div>
}