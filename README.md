# azure-dotnet.api

.Net package:

```bash
dotnet add package Microsoft.ApplicationInsights.AspNetCore --version 2.22.0
```

Run the API:

```bash
dotnet run --launch-profile https
```

Endpoints:

- https://localhost:7027/logging/4xx
- https://localhost:7027/logging/5xx
- https://localhost:7027/logging/error
- https://localhost:7027/logging/exception
