import { Directive, ElementRef, EventEmitter, HostListener, Output } from "@angular/core";

@Directive({
    selector: '[appClickOutside]',
    standalone: true
})
export class ClickOutsideDirective {
    @Output() public appClickOutside = new EventEmitter<void>();

    constructor(private elementRef: ElementRef) { }

    @HostListener('document:mousedown', ['$event'])
    public onDocumentClick(event: PointerEvent) {
        const nativeElement = this.elementRef.nativeElement;
        const isClickedInside = nativeElement.contains(event.target);

        if (!isClickedInside) {
            this.appClickOutside.next();
        }
    }
}