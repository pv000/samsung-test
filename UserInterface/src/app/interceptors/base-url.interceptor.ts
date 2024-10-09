import { HttpEvent, HttpHandlerFn, HttpRequest } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from "../../environments/environment";

export function baseUrlInterceptor(req: HttpRequest<any>, next: HttpHandlerFn): Observable<HttpEvent<any>> {
    const baseUrl = environment.baseUrl;
    const apiReq = req.clone({ url: `${baseUrl}/${req.url}` });
    return next(apiReq);
}